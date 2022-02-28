function getFileExtension(filename){

    // get file extension
    const extension = filename.split('.').pop();
    return extension;
}
// passing the filename
const result1 = getFileExtension('demo.js');
console.log(result1);

const result2 = getFileExtension('demo.txt');
console.log(result2);