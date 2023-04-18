import { Button, Container, Divider, Paper, Typography } from "@mui/material";
import { Link, useLocation, useNavigate } from "react-router-dom";

export default function ServerError() {
  const navigate = useNavigate();
  const { state } = useLocation();

  return (
    <Container component={Paper}>
      {state?.error ? (
        <>
          <Typography variant="h3" color="error" gutterBottom>
            {state.error.title}
          </Typography>
          <Divider />
          <Typography variant="h5" gutterBottom>
            {state.error.detail || "Internal server error"}
          </Typography>
        </>
      ) : (
        <Typography variant="h5" gutterBottom>
          Server error
        </Typography>
      )}
      <Typography variant="h5" gutterBottom>
        Server Error
      </Typography>
      <Link to="/catalog">
        <Button onClick={() => navigate("/catalog")}>
          <p>Back to catalog!</p>
        </Button>
      </Link>
    </Container>
  );
}
