import {useWatch} from "react-hook-form";
import {Dispatch, SetStateAction, useRef} from "react";
import {FormFieldAttributes, FormSchema} from "../../Services/formSchemaService.ts";

export function fieldEquals(fieldName: string, value: string | number | object | (string | number | object)[]){
    return () => {
        const result = useWatch({
            name: [fieldName.toLowerCase()]
        })

        const values = Array.isArray(value) ? value : [value];
        if(result.length > 0) {
            return values.some(v => result[0] === v);
            // return result[0] === value;
        }

        return false;
    }
}

export function fieldEqualsThenSetTo(fieldName: string, value: string | number | object | boolean, newValue: string | number | object | boolean){
    return () => {
        const result = useWatch({
            name: [fieldName.toLowerCase()]
        })

        const cachedValue = useRef(null);

        if(result.length > 0){
            if(cachedValue.current !== result[0]){
                cachedValue.current = result[0];
                // console.log({shouldSet: result[0] === value, result: result[0], value, newValue})
                return {shouldSet: result[0] === value, newValue};
            }
            return false;
        }

        cachedValue.current = null;
        return false;
    }
}


export function mergeFormSchema(schema: FormSchema, setSchema: Dispatch<SetStateAction<Record<string, FormFieldAttributes> | undefined>>, setValue: (fieldName: string, value: string | number | object | boolean | undefined) => void){
    if(!schema || Object.keys(schema).length === 0) {
        console.log("Not merging from schema:", schema)
        return;
    }
    console.log("Merging Form Schema", schema)
    for (const schemaKey in schema) {
        if(schema[schemaKey].clear){
            setValue(schemaKey, undefined);
            delete schema[schemaKey].clear;
        }
        if(schema[schemaKey].value){
            setValue(schemaKey, schema[schemaKey].value);
            delete schema[schemaKey].value;
        }
    }

    setSchema(oldSchema => {
        return deepMerge({...(oldSchema ?? {})}, {...schema});
    });
}

// The types on this is wrong. the value is not always of type T it can be anything except Vite has eslint preventing using 'any' explicitly.
function deepMerge<T extends object>(target: Record<string, T>, source: Record<string, T>) {
    // Iterate through each key in the source object
    for (const key in source) {
        // Check if the key exists in the source object itself (not inherited)
        if (Object.prototype.hasOwnProperty.call(source, key)) {
            // If the value is an object, recursively merge
            if (source[key] && typeof source[key] === 'object' && !Array.isArray(source[key])) {
                // Ensure the target has the key initialized to an object if it doesn't already
                if (!target[key] || typeof target[key] !== 'object') {
                    target[key] = {};
                }
                // Recursively merge the objects
                deepMerge(target[key] as Record<string, T>, source[key] as Record<string, T>);
            } else {
                // Otherwise, overwrite the value in the target object
                target[key] = source[key];
            }
        }
    }
    return target;
}

/*function isObject(item: unknown) {
    return (item && typeof item === 'object' && !Array.isArray(item));
}*/
