var regions=[
    {
        "region_name": "Житомирська область",
        "region_code": "Jit",
        "social": 28
    },
    {
        "region_name": "Севастополь",
        "region_code": "Sev",
        "social": 1
    },
    {
        "region_name": "Крим",
        "region_code": "Cri",
        "social": 27
    },
    {
        "region_name": "Черкаська область",
        "region_code": "Cherka",
        "social": 27
    },
    {
        "region_name": "Чернігівська область",
        "region_code": "Chernig",
        "social": 26
    },
    {
        "region_name": "Чернівецька область",
        "region_code": "Cherniv",
        "social": 13
    },
    {
        "region_name": "Дніпропетровська область",
        "region_code": "Dni",
        "social": 51
    },
    {
        "region_name": "Донецька область",
        "region_code": "Don",
        "social": 63
    },
    {
        "region_name": "Івано-Франківська область",
        "region_code": "Ivan-Frank",
        "social": 19
    },
    {
        "region_name": "Харківська область",
        "region_code": "Har",
        "social": 42
    },
    {
        "region_name": "Херсонська область",
        "region_code": "Her",
        "social": 23
    },
    {
        "region_name": "Хмельницька область",
        "region_code": "Hme",
        "social": 28
    },
    {
        "region_name": "Київ",
        "region_code": "Kie",
        "social": 12
    },
    {
        "region_name": "Київська область",
        "region_code": "Kiev_obl",
        "social": 34
    },
    {
        "region_name": "Луганська область",
        "region_code": "Lug",
        "social": 31
    },
    {
        "region_name": "Кіровоградська область",
        "region_code": "Kir",
        "social": 26
    },
    {
        "region_name": "Львівська область",
        "region_code": "Lviv",
        "social": 28
    },
    {
        "region_name": "Миколаївська область",
        "region_code": "Mik",
        "social": 24
    },
    {
        "region_name": "Одеська область",
        "region_code": "Ode",
        "social": 35
    },
    {
        "region_name": "Полтавська область",
        "region_code": "Pol",
        "social": 33
    },
    {
        "region_name": "Рівненська область",
        "region_code": "Riv",
        "social": 21
    },
    {
        "region_name": "Сумська область",
        "region_code": "Sum",
        "social": 25
    },
    {
         "region_name": "Тернопільська область",
        "region_code": "Ter",
        "social": 20
     },
     {
        "region_name": "Закарпатська область",
        "region_code": "Zak",
        "social": 19
     },
     {
        "region_name": "Вінницька область",
        "region_code": "Vin",
        "social": 33
      },
     {
        "region_name": "Волинська область",
        "region_code": "Vol",
        "social": 20
     },
     {
        "region_name": "Запорізька область",
        "region_code": "Zap",
        "social": 25
  }
];


var temp_array= regions.map(function(item){
    return item.social;
});
var highest_value = Math.max.apply(Math, temp_array);

$(function() {

    for(i = 0; i < regions.length; i++) {

        $('#'+ regions[i].region_code)
        .css({'fill': 'rgba(11, 104, 170,' + regions[i].social/highest_value +')'})
        .data('region', regions[i]);
    }

    $('.map g').mouseover(function (e) {
        var region_data=$(this).data('region');
        $('<div class="info_panel">'+
            region_data.region_name + '<br>' +
          	'social: ' + region_data.social.toLocaleString("en-Uk") +
          	'</div>'
         )
        .appendTo('body');
    })
    .mouseleave(function () {
        $('.info_panel').remove();
    })
    .mousemove(function(e) {
        var mouseX = e.pageX, //X coordinates of mouse
            mouseY = e.pageY; //Y coordinates of mouse

        $('.info_panel').css({
            top: mouseY-50,
            left: mouseX - ($('.info_panel').width()/2)
        });
    });
  });