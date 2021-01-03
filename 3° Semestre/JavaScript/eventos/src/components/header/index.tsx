import React from 'react';
import { Link } from 'react-router-dom';
import './style.css';
import '../../Assets/style/global.css';

interface HeaderProps{
    title: string;
}

const Header: React.FC<HeaderProps> = (props) =>{
    return(
        <div>
            <header>
                <nav>
                    <div>
                        <h3>{props.title}</h3>
                    </div>
                    <ul className="menu">
                        <li><Link className="link" to="/">Home</Link></li>
                        <li><Link className="link" to="/login">Login</Link></li>
                        <li><Link className="link" to="/eventos">Eventos</Link></li>
                    </ul>
                </nav>
            </header>
        </div>
    );
}

export default Header;