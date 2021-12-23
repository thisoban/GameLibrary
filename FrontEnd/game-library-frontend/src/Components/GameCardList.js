import React from 'react'
import axios from "axios";
import { Variables } from "./ApiUrls";
import GameCard from './GameCard';





export const GameCardList = (props) => {
    console.log(props.Games);
    return (
        <div className="listcardgames">
            { /*laat alle kaarten in een rij zien */}
            {props.Games.map((item,i) =>{
                return(  <div>
                    <GameCard game={item}/>
                    </div>
            )})}
        </div>
    )
}

