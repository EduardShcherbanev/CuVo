import React from 'react';
import ReactDOM from 'react-dom';

export default class UserWordCard extends React.Component {

    render() {
        let cardId = "card" + this.props.item.userWordId;
        let descriptionId = "desc" + this.props.item.userWordId;
        let editDescriptionId = "editdesc" + this.props.item.userWordId;

        return (
            <div key={this.props.item.userWordId} id={cardId} className="card white">

                <div className="card-content">
                    <p className="card-title activator">{this.props.item.spelling}<i className="material-icons right">edit</i></p>
                    <p id={descriptionId}>{this.props.item.description}</p>
                </div>

                <div className="card-action">
                    <span>{this.props.item.partOfSpeech}</span>
                    <span className="right">{this.props.item.level}</span>
                </div>

                <div className="card-reveal">
                    <p className="card-title">{this.props.item.spelling}<i className="material-icons right">close</i></p>
                    <div className="input-field">
                        <textarea id={editDescriptionId} className="materialize-textarea" value="{item.description}" />
                        <label htmlFor={editDescriptionId}>Description</label>
                    </div>
                    <a className="waves-effect btn-flat">Delete</a>
                </div>

            </div>
        );
    }
};