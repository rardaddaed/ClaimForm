import axios from 'axios';
import {UseFormReturn} from "react-hook-form";
import {Dispatch, SetStateAction} from "react";

export type OptionItem = {key: string, value: string | number};

export interface FormFieldAttributes {
    enabled?: boolean;
    mandatory?: boolean;
    callback?: boolean;
    maxLength?: number;
    clear?: number;
    items?: OptionItem[] | null;
    value?: string | number | object | boolean | undefined;
    suburbDefinition?: [string, string, string]; //suburb, state, postcode - field names
}

export type FormSchema = Record<string, FormFieldAttributes>;

export type FormContext = UseFormReturn & {schema: FormSchema, setSchema: Dispatch<SetStateAction<Record<string, FormFieldAttributes> | undefined>>, formName: string};



export const getFormSchema = async (formName: string) => {
    const response = await axios.get<Record<string, FormFieldAttributes>>(`http://localhost:5062/${formName}`, {
        headers: {
            'Content-Type': 'application/json'
        }
    });
    console.log("Initial form schema RESPONSE:", response)
    return response.data;
};

export const callback = async (formName: string, postData: {fieldName: string, value: string | number | object | boolean}) => {
    console.log("Callback", formName, postData)
    const response = await axios.post<Record<string, FormFieldAttributes>>(`http://localhost:5062/${formName}/callback`, postData, {
        headers: {
            'Content-Type': 'application/json'
        }
    });
    // console.log("callback form schema RESPONSE:", response)
    console.log("Field", postData.fieldName, " changed to", postData.value,"| callback DATA:", response?.data)
    return response.data;
};

/*
export const postDialogResult = async (dialogName: string, postData: {fieldName: string, value: string | number | object | boolean}) => {
    console.log("Callback", formName, postData)
    const response = await axios.post<Record<string, FormFieldAttributes>>(`http://localhost:5062/${dialogName}/callback`, postData, {
        headers: {
            'Content-Type': 'application/json'
        }
    });
    // console.log("callback form schema RESPONSE:", response)
    console.log("Field", postData.fieldName, " changed to", postData.value,"| callback DATA:", response?.data)
    return response.data;
};
*/

