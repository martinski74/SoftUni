import $ from 'jquery';

const KinveyRequester = (function() {
    const baseUrl = "https://baas.kinvey.com/";
    const appKey = "kid_SyOGkFlXe";
    const appSecret = "aa336c71e47f4bdaba832bbf5888d42d";
    const kinveyAppAuthHeaders = {
        'Authorization': "Basic " + btoa(appKey + ":" + appSecret),
    };

    function loginUser(username, password) {
        return $.ajax({
            method: "POST",
            url: baseUrl + "user/" + appKey + "/login",
            headers: kinveyAppAuthHeaders,
            data: { username, password }
        });
    }
    function registerUser(username,password) {
        return $.ajax({
            method: "POST",
            url: baseUrl + "user/" + appKey + "/",
            headers: kinveyAppAuthHeaders,
            data: { username, password }
        });
    }
    function loadTickets() {
        return $.ajax({
            method: "GET",
            url: baseUrl + "appdata/" + appKey + "/Tickets",
            headers: getKinveyUserAuthHeaders()
        });
    }
    function getKinveyUserAuthHeaders() {
        return {
            'Authorization': "Kinvey " + sessionStorage.getItem('authToken'),
        };
    }
    function createTicket(title,event,date,mail,Quantity) {
        return $.ajax({
            method: "POST",
            url: baseUrl + "appdata/" + appKey + "/Tickets",
            headers: getKinveyUserAuthHeaders(),
            data: {title,event,date,mail,Quantity}
        });
    }
    function editTicket(ticketId, title,event,date,mail,Quantity) {
        return $.ajax({
            method: "PUT",
            url: baseUrl + "appdata/" + appKey + "/Tickets/" + ticketId,
            headers: getKinveyUserAuthHeaders(),
            data: {title,event,date,mail,Quantity}
        });
    }
    function deleteTicket(ticketId) {
        return $.ajax({
            method: "DELETE",
            url: baseUrl + "appdata/" + appKey + "/Tickets/" + ticketId,
            headers: getKinveyUserAuthHeaders()
        });
    }

    function findTicketById(ticketId) {
        return $.ajax({
            method: "GET",
            url: baseUrl + "appdata/" + appKey + "/Tickets/" + ticketId,
            headers: getKinveyUserAuthHeaders()
        });
    }

    return{
        loginUser,
        registerUser,
        loadTickets,
        createTicket,
        findTicketById,
        editTicket,
        deleteTicket
    }
})();
export default KinveyRequester;