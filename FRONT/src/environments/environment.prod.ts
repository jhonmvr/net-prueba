export const environment = {
  production: true,
  rootContext:"/mfc-pista",
  isMockEnabled: false, // You have to switch this, when your real back-end is done
  urlCorePista:"http://38.67.136.34:5001/gestion-pista-rest/resources/" ,
  //urlCorePista:"https://localhost:44343/gestion-pista-rest/resources/",
  //urlCorePista:"https://localhost:44343/gestion-pista-rest/resources/",
  apiUrlGeneric:"http://186.4.199.176:18080/generic-relative-rest/resources/",
  apiUrlMail:"http://38.67.136.34:5000/sendMmail?guardar=guardar",
  apiUrlListMongo:"http://38.67.136.34:5000/findByParam",
  apiUrlLoging:"https://pruebas.mfcapitalgroup.com/edimcapruebasWA/api/LoginPistas",
  tokenKey:"RE000",
  userdata:"RE001",
  userKey:"RE002",
  rolKey:"RE003",
  emailKey:"RE004",
  sucursalKey:"RE004",
  comodin:"9KxQ==",
  mongoColNotif:"col_notificacion",
};
