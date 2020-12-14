@php
    $links = [
        [
            'icono' =>  'fab fa-whatsapp',
            'link' => 'https://api.whatsapp.com/send?phone=+5493415929979',
            'color' => '#4FCE5D'
        ],
        [
            'icono' =>  'fab fa-facebook-f',
            'link' =>   'https://www.facebook.com/david.zisele/',
            'color' => '#3B5998'
        ],
        [
            'icono' =>  'fab fa-linkedin-in',
            'link' =>   'https://www.linkedin.com/in/david-zisele-79a982168/',
            'color' => '#0E76A8'
        ],
        [
            'icono' =>  'fab fa-git',
            'link' =>   'https://github.com/DavidLZisele',
            'color' => '#043b6a'
        ],
    ]
@endphp 

<footer>
    <div class="d-flex flex-wrap bg-title p-lg-5 align-items-center">
        <div class="col-lg-6">
            <h5>
                Desarrollado por - David Zisele <i class="fas fa-code"></i>
                <br>
                Desarrollador Freelance
            </h5>
        </div>
        <div class="col-lg-6 d-flex flex-wrap">
            @foreach ($links as $link)
                <div class="col-3">
                    <a target="_blank" class="btn w-100" href="{{$link['link']}}" style="background-color: {{$link['color']}}"><i class="{{$link['icono']}} p-2 my-auto text-white fa-2x"></i></a>
                </div>
            @endforeach
        </div>
    </div>
    
</footer>