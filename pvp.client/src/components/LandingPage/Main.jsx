import * as React from 'react';
import Box from '@mui/material/Box';
import Container from '@mui/material/Container';
import Typography from '@mui/material/Typography';
import Track from "../../assets/Screenshot_1.png";
import Connect from "../../assets/Screenshot_2.png";
import Challenge from "../../assets/Screenshot_3.png";
import './Hero.css';

export default function Main() {
    return (

        <Container
            sx={{
                width: '70%',
                flexDirection: 'column',
                marginBottom: '100px',
                marginTop: '150px'
            }}
        >
            <Box sx={{
                margin: '0 auto',
                gap: '2%',
                display: 'flex',
                flexWrap: 'wrap',
                justifyContent: 'space-around',
                marginBottom: '10px'
            }}>
                <Box className='bubbleHover' sx={{
                    width: '250px',
                    height: '350px',
                    marginBottom: "20px",
                    boxShadow: '0px 0px 5px 1px rgba(0,0,0,0.25)',
                    borderRadius: '10px',
                    backgroundColor: '#FFFFFF',

                }}>
                    <Typography margin='10px' variant='h4'>CHAT</Typography>
                    <Box>
                        <img src={Track} alt="Track" />
                        <Typography marginBottom='10px' marginTop='0px'><u>Chat</u> with friends!</Typography>
                    </Box>
                </Box>
                <Box className='bubbleHover' sx={{
                    width: '250px',
                    height: '350px',
                    boxShadow: '0px 0px 5px 1px rgba(0,0,0,0.25)',
                    borderRadius: '10px',
                    backgroundColor: '#FFFFFF',
                    marginBottom: "20px",
                }}>
                    <Typography margin='10px' variant='h4'>CONNECT</Typography>
                    <Box>
                        <img src={Connect} alt="Connect" />
                        <Typography marginBottom='10px' marginTop='30px'><u>Connect</u> with hunters!</Typography>
                    </Box>
                </Box>
                <Box className='bubbleHover' sx={{
                    width: '250px',
                    height: '350px',
                    boxShadow: '0px 0px 5px 1px rgba(0,0,0,0.25)',
                    borderRadius: '10px',
                    backgroundColor: '#FFFFFF',
                    marginBottom: "20px",
                }}>
                    <Typography margin='10px' marginBottom='20px' variant='h4'>PLAN</Typography>
                    <Box>
                        <img src={Challenge} alt="Challenge" />
                        <Typography marginBottom='10px' marginTop='0px'><u>Plan</u> your huntings!</Typography>
                    </Box>
                </Box>
            </Box>
        </Container>
    );
}