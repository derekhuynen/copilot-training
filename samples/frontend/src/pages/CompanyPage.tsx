import { Box, CircularProgress, Typography } from "@mui/material";
import { useParams } from "react-router-dom";
import { useQuery } from '@tanstack/react-query';
import { apiClient } from "service/axiosConfig";
import { OrderRequest } from "types/order";

const fetchCompany = async (companyId: string) => {
  const response = await apiClient.get<OrderRequest>(
    `/api/orders/company?companyId=${companyId}`
  );
  return response.data;
};

const CompanyPage = () => {
  const { id } = useParams<{ id: string }>();
  const { data: orderRequest, isLoading, error } = useQuery({
    queryKey: ["orders", id],
    queryFn: () => fetchCompany(id || ""),
    enabled: !!id,
  });

  if (isLoading) return <CircularProgress />;
  if (error) return <Typography color="error">Failed to load order data</Typography>;


  return (
    <Box>
      {id}
      {/* Add more fields as needed */}
    </Box>
  );
};

export default CompanyPage;
