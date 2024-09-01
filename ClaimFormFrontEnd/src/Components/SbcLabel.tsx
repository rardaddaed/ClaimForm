import {FC} from "react";

interface SbcLabelProps {
    associatedControlID?: string
    text: string
    hasError?: boolean
}

export const SbcLabel: FC<SbcLabelProps> = ({associatedControlID, text, hasError = false}) => {

    if(!text)
        return null;

    return (
        <label htmlFor={associatedControlID} className={"label " + (hasError ? " ErrorLabel" : "")} id={`${associatedControlID}:label`} >
            {text}
        </label>
    );
}
