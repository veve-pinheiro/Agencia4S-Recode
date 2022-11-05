package br.com.aplicationmvc.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class DestinoController {
	
	@RequestMapping("/reservarDestino")
	
	public String form() {
		return "reserva/formReserva";
	}

}
