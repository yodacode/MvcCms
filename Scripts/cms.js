$(function () {

    $('.alert .close').click(function () {
        $('.alert').slideUp();
    });


    var AjaxComplete = function () {
        alert('ajax end');
    }


    $currentUser = $('.author-name').text();
    $('#Author').val($currentUser);

    $currentDate = $('.current-date').text();
    $('#Date').val($currentDate);


    $('.archive').hide();
    $('#home .dropdown-menu').removeClass();

    var monthTab = [];
    var yearTab = [];
    
   var monthMatch = {
        "01": "janvier",
        "02": "fevrier",
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


        if (yearTab.year == undefined) {
            yearTab[year] = [];
        } 
 
    });

    var entry = $('.archive li').each(function (i) {
        var year = $(this).find('.year').text();
        var month = $(this).find('.month').text();
        yearTab[year].push(month);
        

        
        var names = yearTab[year].sort();
        var uniqueMonth = [];
        $.each(names, function (i, el) {
            if ($.inArray(el, uniqueMonth) === -1) {
                uniqueMonth.push(el);
            }
        });
        
        yearTab[year] = uniqueMonth;

    });



    var entry = $('.archive li').each(function (i) {

        var $year = $('.' + $(this).find('.year').text());
        var year = $(this).find('.year').text()

        if ($year.length == 0) {

            //$('#archive').append('<li class="' + year + '"><a href="/Post/GetArchives?year=' + year + '">' + year + '</a></li>');

            $('#archive').append('<li class="' + year + '"><h4>' + year + '</h4></li>');


            for (var j = 0; j < yearTab[year].length; j++) {
                $('.' + year).append('<div class="small"><a href="/blog/archives/'+year+'/'+yearTab[year][j]+'">' + monthMatch[yearTab[year][j]] + '</a></div>');
            } 

        }
    });
    


});