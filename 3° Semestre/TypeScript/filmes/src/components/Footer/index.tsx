import React from 'react';
import '../../assets/global.css';
import './style.css';
import logonegativo from '../../assets/images/logonegativo.png';

function Footer() {
  return (
    <div className="footer">
      
      <div className="section-container-footer">
            <div className="section-container-logo">
                <img src={logonegativo} alt="Logotipo de Filmes Collection"/>
            </div>
            <div className="section-container-barra">
                <hr/>
            
            </div>
            <div className="section-container-info">
                <a>Company Inc., 8901 Marmora Road, Glasgow, D04 89GR</a>
                <a>Call us now toll free: (800)2345-6789</a>
                <a>Customer support: support@demolink.org</a>
                <a> Skype: sample-username</a>
            </div>
        </div>
    </div>
  );
}

export default Footer;