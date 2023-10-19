import { Box, Typography, Pagination } from "@mui/material";
import { Metadata } from "../layout/models/pagination";
import { useState } from "react";

interface Props {
  metaData: Metadata;
  onPageChanged: (page: number) => void;
}

export default function AppPagination({ metaData, onPageChanged }: Props) {
  const { currentPage, totalPages, totalCount, pageSize } = metaData;
  const [pageNumber, setPageNumber] = useState(currentPage);

  function handlePageChange(page: number) {
    setPageNumber(page);
    onPageChanged(page);
  }

  return (
    <Box display="flex" justifyContent="space-between" alignItems="center">
      <Typography>
        Displaying {(currentPage - 1) * pageSize + 1}-
        {currentPage * pageSize > totalCount
          ? totalCount
          : currentPage * pageSize}{" "}
        of {totalCount} items
      </Typography>
      <Pagination
        color="secondary"
        size="large"
        count={totalPages}
        page={pageNumber}
        onChange={(e, page) => handlePageChange(page)}
      />
    </Box>
  );
}
