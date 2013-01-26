$(function () {

    $('.alert .close').click(function () {
        $('.alert').slideUp();
    });


    var AjaxComplete = function () {
        alert('ajax end');
    }

  
    $('.archive').hide();

    $currentUser = $('.author-name').text();
    $('#Author').val($currentUser);

    $currentDate = $('.current-date').text();
    $('#Date').val($currentDate);


    var monthTab = [];
    var yearTab = [];
    
   var monthMatch = {
        "01": "janvier",
        "02": "février",
        "03": "mars",
        "04": "avril",
        "05": "mai",
        "06": "juin",
        "07": "juillet",
        "08": "Aout",
        "09": "septembre",
        "10": "octobre",
        "11": "novembre",
        "12": "decembre",
    }
 

    var items = $('.archive li').each(function (i) {

        var year = $(this).find('.year').text();
        var month = $(this).find('.month').text();

        console.log(year, month);

        if (yearTab.year == undefined) {

            

            yearTab[year] = [];
            if (yearTab[year].month == undefined) {
                yearTab[year].push(month);
            }

        }

        
        
    });




    console.log(yearTab);

    var entry = $('.archive li').each(function (i) {

        var $year = $('.' + $(this).find('.year').text());
        var year = $(this).find('.year').text()

        if ($year.length == 0) {

            $('#archive').append('<li class="' + year + '"><a href="/Post/GetArchives?year='+year+'">' + year + '</a></li>');

            console.log(yearTab[year].length);
            console.log(monthMatch);
            for (var j = 0; j < yearTab[year].length; j++) {

                $('.' + year).append('<div class="small"><a href="/Post/GetArchives?month=' + yearTab[year][j] + '&year=' + year + '">' + monthMatch[yearTab[year][j]] + '</a></div>');

            }

        }
    });
    


});