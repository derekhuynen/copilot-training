import { render, screen } from "@testing-library/react";
import OrderCard from "./OrderCard";
import "@testing-library/jest-dom";

describe("OrderCard Component", () => {
    it("renders without crashing", () => {
        render(<OrderCard />);
        const boxElement = screen.getByRole("presentation");
        expect(boxElement).toBeInTheDocument();
    });

});