<!DOCTYPE html>
<html lang="en">
 @include('layout._htmlHeader')
<body>
    <div class="container bg-body text-white">
        @include('layout._header')
        @yield('main-content')
        @include('layout._footer')
    </div>
    @include('layout._scripts')
</body>
</html>