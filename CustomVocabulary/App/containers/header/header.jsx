import React from 'react';
import $ from "../../../wwwroot/lib/jquery/dist/jquery"
import { Link } from 'react-router-dom';

export default class Header extends React.Component {
    componentDidMount() {
        document.addEventListener('DOMContentLoaded', function () {
            var elems = document.querySelectorAll('.sidenav');
            var instances = M.Sidenav.init(elems);
        });
    }

    render() {
        return (
            <div className="navbar-fixed">
                <nav className="light-blue">
                    <div className="nav-wrapper">
                        <div className="brand-logo">
                            <Link to="/">Custom Vocabulary</Link>
                        </div>
                        <a href="#" data-target="mobile-demo" className="sidenav-trigger"><i className="material-icons">menu</i></a>
                        <ul className="right hide-on-med-and-down">
                            <li>
                                <Link to="/">Home</Link>
                            </li>
                            <li>
                                <Link to="/about">About</Link>
                            </li>
                        </ul>
                    </div>
                </nav>

                <ul className="sidenav" id="mobile-demo">
                    <li>
                        <Link to="/">Home</Link>
                    </li>
                    <li>
                        <Link to="/about">About</Link>
                    </li>
                </ul>
            </div>
        );
    }
};