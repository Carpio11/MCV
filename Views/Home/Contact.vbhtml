@Code
    ViewData("Title") = "Contact"
End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>

<section id="contact">
    <div class="section-content">
        <h1 class="section-header">Entra em contacto <span class="content-header wow fadeIn " data-wow-delay="0.2s" data-wow-duration="2s"> </span></h1>
        <h3>Para mais informações preenche o seguinte formulário: </h3>
    </div>
    <div class="contact-section">
        <div class="container">
            <form>
                <div class="col-md-6 form-line">
                    <div class="form-group">
                        <label for="exampleInputUsername">Name</label>
                        <input type="text" class="form-control" id="" placeholder=" Introduz o teu nome">
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail">Email Address</label>
                        <input type="email" class="form-control" id="exampleInputEmail" placeholder=" Introduz o teu E-mail">
                    </div>
                    <div class="form-group">
                        <label for="telephone">No. Telemóvel</label>
                        <input type="tel" class="form-control" id="telephone" placeholder=" Introduz o contracto móvel">
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="description"> Mensagem</label>
                        <textarea class="form-control" id="description" placeholder="Introduz a mensagem que pretendes enviar"></textarea>
                    </div>
                    <div>

                        <button type="button" class="btn btn-default submit"><i class="fa fa-paper-plane" aria-hidden="true"></i>  Enviar Mensagem</button>
                    </div>

                </div>
            </form>
        </div>
</section>
