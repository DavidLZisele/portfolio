@php
    $habilidades = [
      [
        'lenguaje' => 'PHP',
        'icono' => 'fab fa-php',
        'estrellas'=> 5,
        'framework' => 'Laravel',
        'left' => '37%'
      ],
      [
        'lenguaje' => 'SQL',
        'icono' => 'fas fa-database',
        'estrellas'=> 5,
        'framework' => 'MYSQL, SQL Server',
        'left' => '40%'
      ],
      [
        'lenguaje' => 'JavaScript',
        'icono' => 'fab fa-js-square',
        'estrellas'=> 5,
        'framework' => 'Vue.js',
        'left' => '40%'
      ],
      [
        'lenguaje' => 'CSS3',
        'icono' => 'fab fa-css3-alt',
        'estrellas'=> 5,
        'framework' => 'Bootstrap, SASS',
        'left' => '40%'
      ],
      [
        'lenguaje' => 'HTML5',
        'icono' => 'fab fa-html5',
        'estrellas'=> 5,
        'left' => '40%'
      ],
      [
        'lenguaje' => 'GIT',
        'icono' => 'fab fa-git-square',
        'estrellas'=> 5,
        'left' => '40%'
      ],
      [
        'lenguaje' => 'Java',
        'icono' => 'fab fa-java',
        'estrellas'=> 3,
        'left' => '40%'
      ]   
];
 
 $estudios = [
      [
        'Universidad' => 'UTN Rosario',
        'Carrera' => 'Ing en Sistemas',
        'Fecha'=> '2014 / Cursando',
        'estado' => false
      ],
      [
        'Instituto' => 'Educacion IT',
        'Carrera' => 'Java',
        'Fecha'=> '2019 / Finalizado',
        'estado' => true
      ],
      [
        'Instituto' => 'Digital House',
        'Carrera' => 'Fullstack web',
        'Fecha'=> '2019 / Finalizado',
        'estado' => true
      ],

];
$trabajos = [
      
      'Estudio Rompecabezas' => [ 
        [
          'nombre' => 'Microimplantes',
          'link' => 'https://www.microimplantesarg.com.ar/',
          'img'=> '/img/micro.png',
        ],
        
],
  
     'Ian Coworking' => [
      [
          'nombre' => 'Promofiesta',
          'link' => 'https://tienda.promofiesta.com.ar/',
          'img'=> '/img/promofiesta.png',
      ],
      [
        'nombre' => 'Asesor Contable Online',
        'link' => 'https://asesor.papro.com.ar/',
        'img'=> '/img/asesor.png',
      ],
     ]

 ]
@endphp
@extends('layout.layout')

@section('main-content')
  <section class="d-flex flex-wrap px-5 py-3">
      <article class="col-lg-8 col-xl-8" id="skill">
        <div>
            <h3 class="text-uppercase bg-title rounded-pill p-2 text-center mb-2">
              habilidades
               <i class="fas fa-code ml-auto"></i>
            </h3>
            <div class="d-flex flex-wrap justify-content-between px-md-5">
                @foreach($habilidades as $hab)
                    <div class="col-sm-8 col-md-5 col-lg-5 mt-5 col-xl-5 py-4 px-3 mx-auto mx-md-0 rounded" style="border:solid 2px white;box-shadow:0 0 5px 5px cyan;background-color: #00758f;">
                      <div class="position-absolute w-100 text-center" style="top:-25px;left:0">
                        <i class="{{$hab['icono']}} fa-2x rounded-circle px-3 py-2" style="border:solid 2px white;box-shadow: 0 -6px 5px -1px cyan;background-color:#00758f;"></i>
                      </div>     
                        <h6 class="mt-2">Nombre: {{$hab['lenguaje']}}</h6>
                          @if(isset($hab['framework']))
                          <h6>Framework: {{$hab['framework']}}</h6>
                        @endif
                        <h6>Nivel: 
                          @for($i=0; $i< $hab['estrellas']; $i++)
                              <i class="fas fa-star"></i>
                          @endfor
                          @for($i=0; $i< 5-$hab['estrellas']; $i++)
                              <i class="fas fa-star text-secondary"></i>
                          @endfor
                        </h6>
                       
                    </div>
                @endforeach
            </div>
        </div>
          
      </article>
      <article class="col-lg-4 col-xl-4 mt-5 mt-lg-0" id="estudios">
          <div>
              <h3 class="bg-title text-uppercase  rounded-pill p-2 text-center">
                estudios
                <i class="fas fa-user-graduate"></i>
              </h3>
              <div class="d-flex flex-wrap justify-content-between  px-md-5 px-lg-0">
                @foreach($estudios as $est)
                    <div class="col-sm-8 col-md-5 col-lg-8 mx-auto mx-md-0 mx-lg-auto rounded mt-5 p-4" style="border:solid 2px white;box-shadow:0 0 5px 5px cyan;background-color:#00758f">
                      <div class="text-right position-absolute w-100" style="left:-5px;top:5px">
                        <i class="fas fa-award fa-2x {{$est['estado'] ? 'text-success' : 'text-danger'}}"></i>
                      </div>
                      @foreach($est as $key => $e)
                       @if ($key != 'estado')
                       <h6>{{$key}}: {{$e}}</h6>
                       @endif
                        
                        @endforeach
                    </div>
                @endforeach
            </div>
          </div>
      </article>
      <article class="col-lg-12 mt-5" id="trabajos">
          <div>
            <h3 class="col-lg-8 mx-auto bg-title text-uppercase rounded-pill p-2 text-center">
                Trabajos
                <i class="fas fa-user-tie"></i>
            </h3>
            <div class="d-flex flex-wrap justify-content-between mt-4">
                @foreach ($trabajos as $nombre => $trabajo)
                    <div class="col-12 col-lg-6 px-lg-5">
                      <h5 class="bg-title text-uppercase rounded-pill p-2 text-center">
                           {{$nombre}}
                      </h5>
                      <div>
                       @foreach ($trabajo as $unTrab)                 
                            <div class="card col-12 col-lg-8 mx-auto my-4 p-0 border-0 rounded" style="border:solid 2px white !important;">
                              <div class="card-body" style="background-color:#00758f;">
                                <h5 class="card-title ">{{$unTrab['nombre']}}</h5>
                                 <div class="col-12">
                                   <a target="_blank" href="{{$unTrab['link']}}" class="btn btn-primary w-100">Ver más</a>
                                 </div>
                              </div>
                              <img src="{{$unTrab['img']}}" class="card-img-bottom" alt="...">
                            </div>
                        @endforeach
                      </div>
                     
                    </div>
                @endforeach
            </div>
          </div>
      </article>
  </section>
@endsection