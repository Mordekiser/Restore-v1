import { Fragment } from "react/jsx-runtime";
import { Product } from "../../app/Models/Product";
import ProductList from "./ProductList";

type Props = {
  products: Product[];
};
export default function Catalog({ products }: Props) {
  return (
    <Fragment>
      <ProductList products={products} />
    </Fragment>
  );
}
