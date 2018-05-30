import React from "react";
import ReactDOM from "react-dom";
import { connect } from "react-redux";
import { bindActionCreators } from "redux";
import { getVocabulary } from "./vocabularyActions.jsx"
import { UserWordCard } from "./components/userWordCard.jsx"

class Vocabulary extends React.Component {

    componentDidMount() {
        this.props.getVocabulary();
    }

    render() {
        let vocabulary = this.props.vocabulary.map(item => {
            return (
                <UserWordCard key={item.userWordId} item={item} />
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