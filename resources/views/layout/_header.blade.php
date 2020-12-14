<?php
 $nav = [
     [
        'icono' => 'fas fa-user',
        'desc' => 'Sobre mi',
        'link' => '#sobremi'
     ],
     [
        'icono' => 'fas fa-code',
        'desc' =>  'Habilidades',
        'link' => '#skill'
     ],
     [
        'icono' => 'fas fa-user-graduate',
        'desc' => 'Estudios',
        'link' => '#estudios'
     ],
     [
        'icono' => 'fas fa-user-tie',
        'desc' => 'Trabajos',
        'link' => '#trabajos'
     ],
];
$datos = [
    [
        'icono' => 'fas fa-envelope',
        'desc' => 'davidzisele@gmail.com',
     ],
     [
        'icono' =>  'fas fa-phone',
        'desc' => '3415929979',
     ],
     [
        'icono' => 'fas fa-map-marker-alt',
        'desc' => 'Rosario, Santa Fe',
     ],
     [
        'icono' => 'fas fa-birthday-cake',
        'desc' => '09/04/1992',
     ]
];
?>
<header class="sobremi">
    <div class="row m-0 px-5 py-3 p-md-5 justify-content-between text-center text-lg-left">
        <div class="col-12 col-sm-6 col-lg-4">
            <h3 class="bg-title text-uppercase bg-primary rounded-pill p-2 text-center">
                NAVEGA
            </h3>
           <div class="p-3">
                @foreach($nav as $n)
                <a class="text-white" href="{{$n['link']}}">
                   <div class="col-lg-8 mx-auto d-flex m-0 align-items-center justify-content-between mt-2">
                       <div class="col-1">
                            <i class="{{$n['icono']}}"></i>
                       </div>  
                       <h6 class="my-auto col-11 text-left">{{$n['desc']}}</h6>
                   </div>
                </a>
                @endforeach
             </div>
        </div>
        <div class="col-12 col-sm-6  col-lg-4 mt-3 mt-sm-0 text-center">
            <h3 class="bg-title text-uppercase bg-title rounded-pill p-2 text-center">
                Yo soy
            </h3>
            <div>
                <div class="position-relative text-center mx-auto" style="width:160px;height:160px">
                    <div id="animation-photo"class="rounded-circle text-center mx-auto girar mt-4" style="width:160px;height:160px">
                    
                    </div>
                    <div class="position-absolute rounded-circle" style=" top:6px;right:5px;">
                            <img class="rounded-circle" src="/img/foto.jpg" alt=""  width="150px" height="150px">  
                    </div>
                </div>
               
                <h3 class="mt-3 nombre-animation mx-auto" style="letter-spacing: 5px">David Zisele</h3>
                <h6 class="text-title soy-animation" style="letter-spacing: 3px;font-style:italic;font-weight:600">Fullstack Web</h6>
            </div>
        </div> 
        <div class="col-12 col-sm-6 col-lg-4 mt-3  mt-lg-0">
            <h3 class="bg-title text-uppercase bg-primary rounded-pill p-2 text-center">
                Contacto
            </h3>
            <div class="p-3">
                @foreach($datos as $dato)
                   <div class="col-lg-10 col-xl-9 mx-auto d-flex m-0 align-items-center justify-content-between mt-2">
                       <div class="col-1 ml-auto">
                            <i class="{{$dato['icono']}}"></i>
                       </div>  
                       <h6 class="my-auto col-11 text-left">{{$dato['desc']}}</h6>
                   </div>
                @endforeach
            </div>
        </div>
        
    </div>
   
</header>