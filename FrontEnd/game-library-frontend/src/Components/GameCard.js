import * as React from 'react';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import { cardActionAreaClasses } from '@mui/material';


function Cardlist({Cards}){

}

function GameCard(props){ 
    return (
        <div className = "game">
          {/* {Cards.map((Card) => */}
          {/* <div key= {Card.id}> */}
          <div>
            <Card sx={{ maxWidth: 300 }}>
           <CardContent>
             <Typography gutterBottom variant="h5" component="div">
               {props.game.name}
             </Typography>
             <Typography variant="body2" color="text.secondary">
               {props.game.summary}
             </Typography>
           </CardContent>
           <CardActions>
             <Button size="small">Learn More</Button>
           </CardActions>
         </Card>
             </div>
           
          {/* )} */}
               
        </div>
       
      );
}


export default GameCard