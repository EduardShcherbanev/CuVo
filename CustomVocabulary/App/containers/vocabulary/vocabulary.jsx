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
                <div key={item.userWordId} className="card teal">
                    <div className="card-content white-text">
                        <h5 className="card-title">{item.spelling}</h5>
                        <p>{item.description}</p>
                    </div>
                    <div className="card-action white-text">
                        <span className="badge">{item.level}</span>
                        {item.partOfSpeech}
                        <span className="badge">{item.language}</span>
                    </div>
                </div>
            );
        });

        return (
            <div id="vocabulary" className="row">
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