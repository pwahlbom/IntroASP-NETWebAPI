namespace IntroASP_NETWebAPI.Controllers {

    export class HomeController {
        public message = "Hello from the home page!";

        private ProductResource;
        public product;
        public products;

        constructor(private $resource: angular.resource.IResourceService) {
            this.ProductResource = $resource('/api/products/:id');
            this.getProducts();
        }

        public getProducts() {
            this.products = this.ProductResource.query();
        }

        public save() {
            this.ProductResource.save(this.product).$promise.then(() => {
                this.product = null;
                this.getProducts();
            });
        }
    }

    export class MoviesController {
        public message = "Hello from the movies page!";

        private MovieResource;
        public movie;
        public movies;

        constructor(private $resource: angular.resource.IResourceService) {
            this.MovieResource = $resource('/api/movies/:id');
            this.getMovies();
        }

        public getMovies() {
            this.movies = this.MovieResource.query();
        }

        public save() {
            this.MovieResource.save(this.movie).$promise.then(() => {
                this.movie = null;
                this.getMovies();
            });
        }
    }

    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
