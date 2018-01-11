import React, {Component} from 'react';
import './Footer.css';
import fbLogo from '../images/facebook.jpg';
import twLogo from '../images/Twitter-icon.png';
import gitLogo from '../images/index.png';

export default class Footer extends Component {
    render() {
        return (
            <div className="footer-view">
                (c) 2016 - ReactJS Tickets Store by Double Team
                <a href="https://www.facebook.com/" target="_blank"><img src={fbLogo} alt="logoFb" width={20} height={20}/></a>
                <a href="https://twitter.com/" target="_blank"><img src={twLogo} alt="twitlogo" width={20} height={20}/></a>
                <a href="https://github.com/" target="_blank"><img src={gitLogo} alt="gitLogo" width={20} height={20}/></a>
            </div>

        )
    }
}



