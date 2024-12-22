import * as React from 'react';
import Box from '@mui/material/Box';
import Grid from '@mui/material/Grid';
import Sidebar from "../components/Sidebar";
import CssBaseline from '@mui/material/CssBaseline';
import About from "../components/LandingPage/Main";


export default function HabitsPage() {


    return (
        <Box component="main" sx={{ display: 'flex', minHeight: '100vh'}}>
            <CssBaseline />
            <Sidebar />
            <About></About>
        </Box>
    );
}
