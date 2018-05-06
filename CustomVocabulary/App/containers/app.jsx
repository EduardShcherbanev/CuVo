import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import About from "./about/about.jsx";
import Header from "./header/header.jsx";
import Vocabulary from "./vocabulary/vocabulary.jsx";

export default class App extends React.Component {
    render() {
        return (
            <Router baseName="CustomVocabulary">
                <div>
                    <Header />
                    <div className="container body-content">
                        <main>
                            <Switch>
                                <Route path="/about" component={About} />
                                <Route path="/" component={Vocabulary} />
                            </Switch>
                        </main>
                        <hr />
                        <footer>
                            <p>&copy; 2018 - Custom Vocabulary</p>
                        </footer>
                    </div>
                </div>
            </Router>
        );
    }
};