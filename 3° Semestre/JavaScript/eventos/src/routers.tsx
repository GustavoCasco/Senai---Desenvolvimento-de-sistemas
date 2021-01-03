import React from 'react';
import {BrowserRouter, Route} from 'react-router-dom';
import Home from './pages/home';
import Login from './pages/login';
import Eventos from './pages/eventos';

function Routers(){
    return(
        <BrowserRouter>
            <Route path="/" exact component={Home}/>
            <Route path="/login" component={Login}/>
            <Route path="/eventos" component={Eventos}/>
        </BrowserRouter>
    );
}


export default Routers;