$(function () {

    let currentTimeApiUrl = `${_apiUrl}currenttime`,
        timeListBody = $('#timeList').find('tbody'),
        timeZone = $('#timeZone');
    
    $(document).ready(function () {
        timeZone.val('UTC');

        initList();

        $('#getTime').click(function () {
            $.get(currentTimeApiUrl, { timeZone: timeZone.val()},  function (data) {
                timeListBody.prepend(buildTimeRow(data));
            });
        });
    });

    let initList = function () {
        $.get(`${currentTimeApiUrl}/list`, function (data) {
            let rows = [];
            for (var x = 0; x < data.length; x++) {
                const time = data[x];
                rows.push(buildTimeRow(time));
            }

            timeListBody.html(rows.join(''));
        });
    },
    buildTimeRow = function (time) {
        return `<tr>
                    <td>${time.currentTimeQueryId}</td>
                    <td>${time.clientIp}</td>
                    <td>${moment(time.time).format('lll')}</td>
                    <td>${time.timeZone}</td>
                    <td>${moment(time.utcTime).format('lll')}</td>
                </tr>`;
    }
});