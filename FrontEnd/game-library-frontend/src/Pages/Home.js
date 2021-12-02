import { Variables } from '../Components/ApiUrls';
import axios from "axios";
import GameCard from '../Components/GameCard'
import React from 'react'   
import { GameCardList } from '../Components/GameCardList'
// import { buttonBaseClasses } from '@mui/material';
// import { display } from '@mui/system';


function Home() {

    const [productionlines, setproductionlines] = useState([])

    async function getAllGames() {
        try {
            const apirequest = await axios.get(Variables.GetAllProductionLinesUrl);
            return apirequest.data;
        } catch (error) {
            console.error(error);
        }
    }

    async function GetGames() {
        setproductionlines(await getAllGames());
        return;
    }

    useEffect(() => {
        GetGames()
    })
    return (
       
        <div>
            <div class="container">
            <GameCardList></GameCardList>
            </div>
            <p>home page</p>
        </div>
                     
    )
}

export default Home