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

function GameCard(){ 
    return (
        <div className = "game">
          {Cards.map((Card) =>
          <div key= {Card.id}>
            <Card sx={{ maxWidth: 300 }}>
           <CardMedia
             component="img"
             height="140"
             image="/static/images/cards/contemplative-reptile.jpg"
             alt="green iguana"
           />
           <CardContent>
             <Typography gutterBottom variant="h5" component="div">
               Lizard
             </Typography>
             <Typography variant="body2" color="text.secondary">
               Lizards are a widespread group of squamate reptiles, with over 6,000
               species, ranging across all continents except Antarctica
             </Typography>
           </CardContent>
           <CardActions>
             <Button size="small">Learn More</Button>
           </CardActions>
         </Card>
             </div>
           
          )}
               
        </div>
       
      );
}


export default GameCard