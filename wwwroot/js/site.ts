const Take_fun = (fun_arg: (x: number) => void) => {
    return fun_arg(3);
}

Take_fun((x) => { console.log(x) })



const file_input = document.getElementById("file_input") as HTMLInputElement
const submit_file = document.getElementById("submit_file") as HTMLButtonElement

submit_file.addEventListener("click", () => {
    if (file_input == null || submit_file == null)
        return





    for (let index = 0; index < file_input.files.length; index++) {
        const element = file_input.files.item(index)
        const encoded = encodeURI(file_input.files.item(index).name)
        element.arrayBuffer().then((buffer) => {
            fetch(`/api/UploadRecieve/${encoded}`, {
                method: "POST",
                body: buffer
            })
        })
    }
})