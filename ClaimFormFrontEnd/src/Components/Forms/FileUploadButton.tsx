import {useFormContext} from "react-hook-form";
import {ChangeEvent, ReactElement, useRef} from "react";

interface FileUploadButtonProps {
    id: string
}

const FileUploadButton = ({id}: FileUploadButtonProps): ReactElement => {

    const { register, setValue, watch } = useFormContext();
    const inputRef = useRef<HTMLInputElement | null>(null);

    const handleFileUpload = (event: ChangeEvent<HTMLInputElement>) => {
        // console.log('files')
        if(!event.target.files)
            return;

        if (event.target.files.length > 0) {
            for (const file of event.target.files) {
                console.log("File in upload:", file);
            }
            // console.log("Uploaded files:", event.target.files)
            console.log("existing: ", watch(id))
            const currentFiles = (watch(id) || []) as File[];
            console.log("Is current files array:", Array.isArray(currentFiles))
            // console.log("Current Files:", currentFiles.map(x => x.name));
            setValue(id, [...currentFiles, ...Array.from(event.target.files)]);
            event.target.value = "";
        }
    };

    const { ref, ...rest } = register(id+"input", {
        onChange: handleFileUpload,
    });

    return (
        <div id="ctl00_FullWidthContainer_SupportingDocumentDiv_UploadLink" className="btn btn-primary btn-upload" style={{borderTopRightRadius: "0.25rem !important", borderBottomRightRadius: "0.25rem !important"}}>
            <input
                type="file"
                id={id}
                multiple
                {...rest}
                // onChange={x => setValue('uploadedFiles', x)}
                ref={(e) => {
                    ref(e)
                    inputRef.current = e
                }}
                style={{display: 'none', position: "absolute", left: "-1000px", top: "-1000px", width: 0}}
            />
            <button type="button" onClick={() => inputRef.current?.click()} style={{
                background: "transparent",
                color: "white",
                boxShadow: "none",
                outline: "none",
                textShadow: "none",
                border: "none"
            }}>
                <i className="fa fa-cloud-upload fa-lg" aria-hidden="true"/>&nbsp;Upload
            </button>
        </div>
    )
};

export default FileUploadButton;
