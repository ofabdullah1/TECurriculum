<template>
  <div class="container">
    <table id="tblUsers">
      <thead>
        <tr>
          <th>&nbsp;</th>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Username</th>
          <th>Email Address</th>
          <th>Status</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>
            <input type="checkbox" id="selectAll"
            v-on:change="selectAll($event)"
            v-bind:checked="selectedUserIDs.length === users.length"
            />
          </td>
          <td>
            <input type="text" id="firstNameFilter" v-model="filter.firstName" />
          </td>
          <td>
            <input type="text" id="lastNameFilter" v-model="filter.lastName" />
          </td>
          <td>
            <input type="text" id="usernameFilter" v-model="filter.username" />
          </td>
          <td>
            <input type="text" id="emailFilter" v-model="filter.emailAddress" />
          </td>
          <td>
            <select id="statusFilter" v-model="filter.status">
              <option value>Show All</option>
              <option value="Active">Active</option>
              <option value="Disabled">Disabled</option>
            </select>
          </td>
          <td>&nbsp;</td>
        </tr>
        <tr
          v-for="user in filteredList"
          v-bind:key="user.id"
          v-bind:class="{ disabled: user.status === 'Disabled' }"
        >
          <td>
            <input type="checkbox" v-bind:id="user.id" v-bind:value="user.id" v-bind:checked="selectedUserIDs.includes(user.id)" />
          </td>
          <td>{{ user.firstName }}</td>
          <td>{{ user.lastName }}</td>
          <td>{{ user.username }}</td>
          <td>{{ user.emailAddress }}</td>
          <td>{{ user.status }}</td>
          <td>
            <button class="btnEnableDisable" v-on:click="flipStatus(user.id)">{{user.status === "Active" ? "Disable" : "Enable"}}</button>
          </td>
        </tr>
      </tbody>
    </table>

    <div class="all-actions">
      <button v-on:click="enableSelectedUsers()" v-bind:enabled="actionButtonDisabled">Enable Users</button>
      <button v-on:click="disableSelectedUsers()" v-bind:enabled="actionButtonDisabled">Disable Users</button>
      <button v-on:click="deleteSelectedUsers()" v-bind:enabled="actionButtonDisabled">Delete Users</button>
    </div>

    <button v-on:click="showForm = !showForm">Add New User</button>

    

    <form id="frmAddNewUser" v-on:submit.prevent= "saveUser" v-show="showForm">
      <div class="field">
        <label for="firstName">First Name:</label>
        <input type="text" v-model="newUser.firstName" name="firstName" />
      </div>
      <div class="field">
        <label for="lastName">Last Name:</label>
        <input type="text" v-model="newUser.lastName" name="lastName" />
      </div>
      <div class="field">
        <label for="username">Username:</label>
        <input type="text" v-model="newUser.username" name="username" />
      </div>
      <div class="field">
        <label for="emailAddress">Email Address:</label>
        <input type="text" v-model="newUser.emailAddress" name="emailAddress" />
      </div>

       <input v-on:click="showForm = false" type="button" value="Cancel" />
      <button type="submit" class="btn save">Save User</button>
    </form>
  </div>
</template>

<script>
export default {
  name: "user-list",
  data() {
    return {
      filter: {
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: ""
      },
      
      newUser: {
        id: null,
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "Active"
      },
      showForm: false,

      selectedUserIDs: [],

      users: [
        {
          id: 1,
          firstName: "John",
          lastName: "Smith",
          username: "jsmith",
          emailAddress: "jsmith@gmail.com",
          status: "Active"
        },
        {
          id: 2,
          firstName: "Anna",
          lastName: "Bell",
          username: "abell",
          emailAddress: "abell@yahoo.com",
          status: "Active"
        },
        {
          id: 3,
          firstName: "George",
          lastName: "Best",
          username: "gbest",
          emailAddress: "gbest@gmail.com",
          status: "Disabled"
        },
        {
          id: 4,
          firstName: "Ben",
          lastName: "Carter",
          username: "bcarter",
          emailAddress: "bcarter@gmail.com",
          status: "Active"
        },
        {
          id: 5,
          firstName: "Katie",
          lastName: "Jackson",
          username: "kjackson",
          emailAddress: "kjackson@yahoo.com",
          status: "Active"
        },
        {
          id: 6,
          firstName: "Mark",
          lastName: "Smith",
          username: "msmith",
          emailAddress: "msmith@foo.com",
          status: "Disabled"
        },
      ],
      
    };
  },
  methods: {
    saveUser() {
      this.users.unshift (this.newUser);
      this.resetForm();
    },
   resetForm() {
     this.newUser = {};
     this.showForm = false;
   },
   flipStatus(id) {
     const index = this.findUserById(id);
     this.users[index].status === "Active" ? "Disabled" : "Active";
   },
   selectUser(event) {
     if(event.target.id) {
       this.selectedUserIDs.push(parseInt(event.target.id));
     }else{
       this.selectedUserIDs = this.selectedUserIDs.filter((user) => {
         return user !==parseInt(event.target.id);
       });
     }
   }
  },
  selectAll(event) {
    if (event.target.checked) {
      this.selectedUserIDs = [];
      this.users.forEach((user) => this.selectedUserIDs.push(user.id));
    }else{
      this.selectedUserIDs = [];
    }
  },
  deleteSelectedUsers() {
    this.selectedUserIDs.forEach((id) => {
      this.deleteUser(id);
    });
    this.clearSelectedUsers();
  },
  enableSelectedUsers() {
    this.selectedUserIDs.forEach((id) => {
      this.users[this.findUserById(id)].status = "Active";
    });
    this.clearSelectedUsers();
    
  },
  clearSelectedUsers() {
    this.selectedUserIDs = [];
  },
  findUserById(id) {
    return this.users.findIndex((user) => user.id == id);
  },
  deleteUser(id) {
    this.users = this.users.findIndex((user) => {
      return user.id != id;
    });
  },

  disableSelectedUsers() {
    this.selectedUserIDs.forEach((id) => {
      this.users[this.findUserById(id)].status = "Disabled";
    });
    this.clearSelectedUsers();
    },
  computed: {
    actionButtonDisabled() {
      return this.selectedUserIDs.length == 0;
    },
    filteredList() {
      let filteredUsers = this.users;
      if (this.filter.firstName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.firstName
            .toLowerCase()
            .includes(this.filter.firstName.toLowerCase())
        );
      }
      if (this.filter.lastName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.lastName
            .toLowerCase()
            .includes(this.filter.lastName.toLowerCase())
        );
      }
      if (this.filter.username != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.username
            .toLowerCase()
            .includes(this.filter.username.toLowerCase())
        );
      }
      if (this.filter.emailAddress != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.emailAddress
            .toLowerCase()
            .includes(this.filter.emailAddress.toLowerCase())
        );
      }
      if (this.filter.status != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.status === this.filter.status
        );
      }
      return filteredUsers;
    }
  }
};
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
    Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
  margin-bottom: 20px;
}
th {
  text-transform: uppercase;
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input,
select {
  font-size: 16px;
}

form {
  margin: 20px;
  width: 350px;
}
.field {
  padding: 10px 0px;
}
label {
  width: 140px;
  display: inline-block;
}
button {
  margin-right: 5px;
}
.all-actions {
  margin-bottom: 40px;
}
.btn.save {
  margin: 20px;
  float: right;
}
</style>
