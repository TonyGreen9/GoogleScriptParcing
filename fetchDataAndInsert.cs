function fetchDataAndInsert() {
  // ID google spreadshit
  var spreadsheetId = 'ID google spreadshit';
  var spreadsheet = SpreadsheetApp.openById(spreadsheetId);
  var sheet = spreadsheet.getSheets()[0];
  var lastRow = sheet.getLastRow() + 1;
  sheet.getRange(lastRow, 1).setValue(new Date());
  function parseSales(url, regex) {
    var response = UrlFetchApp.fetch(url);
    var html = response.getContentText();
    var match = regex.exec(html);
    return match ? match[1].replace(/,/g, '') : 'Data not found';
  } 
  // Parsing
  sheet.getRange(lastRow, 1).setValue(parseSales("https://", X));
}
