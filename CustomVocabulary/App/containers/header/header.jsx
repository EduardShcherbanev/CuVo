import React from 'react';

export default class Header extends React.Component {
    render() {
        return (
            <nav className="navbar fixed-top navbar-expand-lg navbar-light bg-light">
                <div className="container">
                    <button type="button" className="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse"
                        aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <a asp-area="" asp-controller="Home" asp-action="Index" className="navbar-brand">Custom Vocabulary</a>

                    <div className="navbar-collapse collapse">
                        <ul className="navbar-nav mr-auto mt-2 mt-lg-0">
                            <li className="nav-item active">
                                <a className="nav-link" asp-controller="Home" asp-action="Index">Home</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        );
    }
};