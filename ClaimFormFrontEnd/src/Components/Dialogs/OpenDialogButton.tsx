import React, {HTMLAttributes, useState} from "react";
import Button from "./Button.tsx";

export interface DialogProps {
    closeDialog: () => void
}

interface OpenDialogButtonProps extends HTMLAttributes<HTMLButtonElement> {
    label: string;
    DialogComponent: React.FC<DialogProps>
}

const OpenDialogButton = ({label, DialogComponent, className = "", ...rest}: OpenDialogButtonProps) => {

    const [dialogOpen, setDialogOpen] = useState(false);

    return (
        <>
            <Button label={label} onClick={() => setDialogOpen(oldValue => !oldValue)} className={className} {...rest} />
            {dialogOpen ? <DialogComponent closeDialog={() => setDialogOpen(false)}/> : null}
        </>
    );
};

export default OpenDialogButton;
