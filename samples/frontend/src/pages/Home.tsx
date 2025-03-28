import { Grid } from "@mui/material"
import CompaniesTable from "./company/CompaniesTable"

const Home = () => {
    return (
        <Grid container>
            <CompaniesTable />
        </Grid>
    )
}

export default Home