import React from 'react';
import ReactDOM from 'react-dom';
import { connect } from 'react-redux';
import { getVocabulary } from './vocabularyActions.jsx'

class Vocabulary extends React.Component {

    componentDidMount() {
        this.props.getVocabulary();
    }

    render() {
        let vocabulary = this.props.map(item => {
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
        posts: state.data,
        error: state.error
    }
}

let mapDispatch = (dispatch) => {
    return {
        getVocabulary: () => dispatch(getVocabulary())
    }
}

export default connect(mapProps, mapDispatch)(Vocabulary) 