import { Fragment } from "react/jsx-runtime";
import { Product } from "../../app/models/Product";
import ProductList from "./ProductList";
import { useEffect, useState } from "react";

export default function Catalog() {
  const [products, setProducts] = useState<Product[]>([]);

   useEffect(() => {
      fetch("https://localhost:7233/api/products")
        .then((response) => response.json())
        .then((data) => setProducts(data));
    }, []);

  return (
    <Fragment>
      <ProductList products={products} />
    </Fragment>
  );
}
