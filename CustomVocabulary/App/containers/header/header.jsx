import React from 'react';

export default class Header extends React.Component {
    render() {
        return (
            <nav className="navbar navbar-inverse navbar-fixed-top">
                <div className="container">
                    <div className="navbar-header">
                        <button type="button" className="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span className="sr-only">Toggle navigation</span>
                            <span className="icon-bar"></span>
                            <span className="icon-bar"></span>
                            <span className="icon-bar"></span>
                        </button>
                        <a asp-area="" asp-controller="HomeOld" asp-action="Index" className="navbar-brand">Custom Vocabulary</a>
                    </div>
                    <div className="navbar-collapse collapse">
                        <ul className="nav navbar-nav">
                            <li><a asp-area="" asp-controller="HomeOld" asp-action="Index">Home</a></li>
                            <li><a asp-area="" asp-controller="HomeOld" asp-action="About">About</a></li>
                            <li><a asp-area="" asp-controller="HomeOld" asp-action="Contact">Contact</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
        );
    }
};