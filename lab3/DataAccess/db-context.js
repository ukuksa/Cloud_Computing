const sql = require('mssql');
const parser = require('mssql-connection-string');


class PeopleDbContext {
    constructor(connectionString, log) {
        log("PeopleDbContext object has been created.");
        this.log = log;
        this.config = parser(connectionString);
        this.getPeople = this.getPeople.bind(this);
    }

    async getPeople() {
        this.log("getPeople function - run")
        const connection = await new sql.ConnectionPool(this.config).connect();
        const request = new sql.Request(connection);
        const result = await request.query('select * from People');
        this.log("getPeople function - done")
        return result.recordset;
    }
    
    async getPerson(FirstName) {
        this.log("getPeople function - run")
        const connection = await new sql.ConnectionPool(this.config).connect();
        const request = new sql.Request(connection);
        const result = await request.query(`select * from People where FirstName = \'${FirstName}\'`);
        this.log("getPeople function - done")
        return result.recordset;
    }
    
    async deletePerson(FirstName) {
        this.log("getPeople function - run")
        const connection = await new sql.ConnectionPool(this.config).connect();
        const request = new sql.Request(connection);
        const result = await request.query(`delete from People where FirstName = \'${FirstName}\'`);
        this.log("getPeople function - done")
        return result.recordset;
    }   
    
    async createPerson(FirstName,LastName) {
        this.log("getPeople function - run")
        const connection = await new sql.ConnectionPool(this.config).connect();
        const request = new sql.Request(connection);
        const result = await request.query(`insert into People (FirstName,LastName) values (\'${FirstName}\',\'${LastName}\')`);
        this.log("getPeople function - done")
        return result.recordset;
    } 
}

module.exports = PeopleDbContext