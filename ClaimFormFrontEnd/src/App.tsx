import Default from "./Pages/Default";
import {useState} from "react";
import {ClaimDetails} from "./Pages/Claim/ClaimDetails.tsx";

function App() {

    const [formIsOpen, setFormIsOpen] = useState(false);

    if(formIsOpen)
        return <ClaimDetails/>

  return (
      <Default openForm={() => setFormIsOpen(true)}/>
  )
}

export default App
