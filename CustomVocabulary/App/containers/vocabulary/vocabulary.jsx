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
        let vocabulary = this.props.vocabulary.map(item => {
            return (
                <div key={item.userWordId} className="card mb-3">
                    <div className="card-body">
                        <h5 className="card-title">{item.spelling}</h5>
                        <p className="card-text">{item.description}</p>
                    </div>
                    <div className="card-footer">{item.partOfSpeech} <span className="badge badge-pill badge-secondary float-right m-1">{item.language}</span></div>
                </div>
            );
        });

        return (
            <div id="vocabulary" className="card-deck">
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