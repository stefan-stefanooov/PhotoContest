(function () {
    $("#numberOfWinners").hide();
    $("#finishTime").hide();
    $("#numberOfParticipants").hide();

    $("#single").click(function (){
        $("#numberOfWinners").hide();

    });

    $("#multiple").click(function () {
        $("#numberOfWinners").show();
    });

    $("#byTime").click(function () {
        $("#numberOfParticipants").hide();
        $("#finishTime").show();
    });

    $("#byNumber").click(function () {
        $("#finishTime").hide();
        $("#numberOfParticipants").show();
    });
})();