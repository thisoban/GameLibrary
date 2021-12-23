
import axios from 'axios';
import { Variables } from "../Components/ApiUrls";
import GameCard from '../Components/GameCard'
import React, {useEffect, useState} from 'react'   
import { GameCardList } from '../Components/GameCardList'
// import { buttonBaseClasses } from '@mui/material';
// import { display } from '@mui/system';
async function GetGames() {
    try {
        const apirequest = await axios.get(Variables.GetGames);
        console.log(apirequest.data)
        return apirequest.data;
    } catch (error) {
        console.error(error);
    }
}



function GamesPage() {
    const [AllGames, SetAllGames] = useState([])

    async function setgames(){
        SetAllGames(await GetGames());
        console.log(AllGames);
        return;
    }
    useEffect(() => {
        setgames();
    },[])
    return (
       
        <div>
         {AllGames.length >= 1 ? <GameCardList Games={AllGames} /> : null}
            <p>Games page</p>
        </div>
                     
    )
}

export default GamesPage