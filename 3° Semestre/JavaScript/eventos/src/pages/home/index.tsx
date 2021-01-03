import React from 'react';
import Header from '../../components/header';
import '../../Assets/style/global.css';
import Footer from '../../components/footer';

function Home(){
    return(
        <div>
            <Header title="A sua plataforma de Eventos"/>
            <h1>Home</h1>
            <Footer/>
        </div>
    );
}

export default Home;