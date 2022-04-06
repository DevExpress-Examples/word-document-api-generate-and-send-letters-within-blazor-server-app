function exportToPdf(filename, base64Content) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/pdf;base64," + base64Content;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}