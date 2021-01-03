import React from 'react';
import Header from '../../components/Header';
import Footer from '../../components/Footer';
import cinema from './../../assets/images/cinema.png'
import choraAgoraRidepois from '../../assets/images/theater.png'
import './style.css'

function Home() {
	return (
		<div className="Home">
			<Header description="Conheça nossa coletanea " />
			<div className="main">
				<h1>Monte sua coletanea de filmes...</h1>
				<p>
					Lorem ipsum arcu orci gravida leo curabitur aptent, sit eleifend mi neque fermentum egestas,
					curae etiam pulvinar neque quis odio. massa taciti torquent sed felis est potenti turpis donec,
					congue facilisis massa arcu dictum duis litora,risus nibh pulvinar nullam velit fames turpis.
					ante pretium ligula convallis aliquam convallis
                </p>
				<div className='container'>
					<img src={cinema} alt="logo cinema" width='100vh' />
					<h3> Filmes</h3>
					<p> Lorem ipsum arcu orci gravida leo curabitur aptent, sit eleifend mi neque fermentum egestas,
					curae etiam pulvinar neque quis odio. massa taciti torquent sed felis est potenti turpis donec,
                    congue facilisis massa arcu dictum duis litora</p>
				</div>
				<div className='section-container2'>
					<img src={choraAgoraRidepois} alt="logo chora agora ri depois" width='100vh' />
					<h3> Categoria</h3>
					<p> Lorem ipsum arcu orci gravida leo curabitur aptent, sit eleifend mi neque fermentum egestas,
					curae etiam pulvinar neque quis odio. massa taciti torquent sed felis est potenti turpis donec,
                    congue facilisis massa arcu dictum duis litora</p>
				</div>
			</div>
			<Footer />
		</div>
	);
}

export default Home;