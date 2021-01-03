import React from 'react';
import logo from './../../assets/images/logo.png'
import '../../assets/global.css';
import './style.css'
import {Link} from 'react-router-dom'

interface headerProps {
  description?:string
}

const Header:React.FC<headerProps> =(props) => {
  return (
    <div className="principal">
        <div className="header">
          <div className="align">
          <nav>
            <Link to='/'>
              <img src={logo} className="Logo"/>
            </Link>
            <ul className='menu'>
              <li>
                <Link to= "/" className='link'>Home</Link>
              </li>
              <li>
                <Link to= "/login"  className='link'>Login</Link>
              </li>
              <li>
                <Link to="/" className='link'>Cadastro</Link>
              </li>
            </ul>
          </nav>
          <h3>
            {props.description}
          </h3>
          </div>
        </div>
    </div>
  );
}

export default Header;