import React from 'react'
import './style.css'
interface Buttonprops{
    value:string
}

const Button: React.FC<Buttonprops> = ({value}) => {
    return (
    <div className='btn'>
       <input className='button' type='submit' value={value}/>  
    </div>
        
    )
}

export default Button;