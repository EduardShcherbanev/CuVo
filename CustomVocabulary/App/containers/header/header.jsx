import React from 'react';

export default class Header extends React.Component {
    render() {
        return (
            <nav className="navbar fixed-top navbar-expand-lg navbar-light">
                <div className="container">
                    <button type="button" className="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <a asp-area="" asp-controller="Home" asp-action="Index" className="navbar-brand">Custom Vocabulary</a>

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