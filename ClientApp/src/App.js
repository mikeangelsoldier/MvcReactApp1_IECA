import 'bootstrap/dist/css/bootstrap.min.css';
// import Tarjeta from './components/Tarjeta';
import { useState, useEffect } from 'react';

const App = () => {

  const [empleados, setEmpleado] = useState([]);

  const ConsumirAPI = async () => {
    const response = await fetch("api/empleado/obtenerEmpleado")

    if (response.ok) {
      const data = await response.json();
      console.log(data);
      setEmpleado(data);
    }
  }

  useEffect(() => {
    ConsumirAPI();

  }, [])

  return (
    <div className="container-fluid">

      <h5>Lista de empleados</h5>
      <table className='table table-striped'>
        <thead>
          <tr>
            <th>ID</th>
            <th>Nombre</th>
            <th>Correo</th>
            <th>Dirección</th>
            <th>Telefono</th>
          </tr>
        </thead>
        <tbody>

          {
            empleados.map((item) => (
              <tr key={item.Id}>
                <td>{item.Id}</td>
                <td>{item.Nombre}</td>
                <td>{item.Correo}</td>
                <td>{item.Direccion}</td>
                <td>{item.Telefono}</td>
              </tr>
            ))
          }

        </tbody>
      </table>

    </div>
  );
}

export default App;
