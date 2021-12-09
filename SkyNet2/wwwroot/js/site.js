﻿function PopulateDays() {
    var ddlMonth = document.getElementById("ddlMonth");
    var ddlYear = document.getElementById("ddlYear");
    var ddlDay = document.getElementById("ddlDay");

    var y = ddlYear.options[ddlYear.selectedIndex].value;
    var m = ddlMonth.options[ddlMonth.selectedIndex].value != 0;

    if (ddlMonth.options[ddlMonth.selectedIndex].value != 0 &&
        ddlYear.options[ddlYear.selectedIndex].value != 0) {

        var dayCount = 32 - new Date(ddlYear.options[ddlYear.selectedIndex].value,
            ddlMonth.options[ddlMonth.selectedIndex].value - 1, 32).getDate();
        ddlDay.options.length = 0;

        for (var i = 1; i <= dayCount; i++) {
            AddOption(ddlDay, i, i);
        }
    }
}

function AddOption(ddl, text, value) {
    var opt = document.createElement("OPTION");
    opt.text = text;
    opt.value = value;
    ddl.options.add(opt);
}