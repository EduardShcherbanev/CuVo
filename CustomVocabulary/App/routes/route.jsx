import React from 'react';
import ReactDOM from 'react-dom';
import { Route, Switch, Redirect } from 'react-router-dom';
import Vocabulary from '../containers/vocabulary/vocabulary.jsx';
//import About from '../containers/about/about.jsx';
//import Translation from '../containers/translation/translation.jsx';
//import Word from '../containers/word/word.jsx';

export default class Routing extends React.Component {

    render() {
        return (
            <div className="container body-content">
                <main>
                    <Switch>
                        <Route path="/about" component={About} />
                        <Route path="/vocabulary/word" component={Word} />
                        <Route path="/vocabulary/translation" component={Translation} />
                        <Route path="/vocabulary" component={Vocabulary} />
                        <Route exact path="/" render={() => (<Redirect to="/vocabulary" />)} />
                    </Switch>
                </main>
                <hr />
                <footer>
                    <p>&copy; 2018 - Custom Vocabulary</p>
                </footer>
            </div>
        );
    }
};
