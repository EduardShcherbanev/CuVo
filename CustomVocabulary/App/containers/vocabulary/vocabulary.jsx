import React from 'react';
import ReactDOM from 'react-dom';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { getVocabulary } from './vocabularyActions.jsx'

class Vocabulary extends React.Component {

    componentDidMount() {
        this.props.getVocabulary();
    }

    render() {
        //return (
        //    <div>{this.props.vocabulary.records.count}</div>
        //    );

        let vocabulary = this.props.vocabulary.records.map(item => {
            return (
                <div key={item.userwordid}>
                    <div>{item.spelling}</div>
                    <div>{item.description}</div>
                    <div>{item.partofspeech}</div>
                    <div>{item.language}</div>
                    <hr />
                </div>
            );
        });

        return (
            <div id="vocabulary">
                {vocabulary}
            </div>
        );
    }
};

let mapProps = (state) => {
    return {
        vocabulary: state.data,
        error: state.error
    }
}

let mapDispatch = (dispatch) => {
    return {
        getVocabulary: bindActionCreators(getVocabulary, dispatch)
    }
}

export default connect(mapProps, mapDispatch)(Vocabulary) 